CC      = mcs
RUN		= mono
NAME    = dungeon
RM      = rm -f
SRC	= \
	main.cs \
	character.cs \
	item.cs \

all:  
	$(CC) -out:$(NAME) $(SRC)

run: 
	$(RUN) $(NAME)

clean:
	$(RM) $(NAME)

fast: all run